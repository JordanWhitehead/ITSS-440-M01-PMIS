using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS____GUI_Design
{
    public class TaskListReport(int projectID)
    {
        public int ProjectID = projectID;
        public void WritePDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Save the Project Charter";
            var dialogResponse = saveFileDialog.ShowDialog();

            if (dialogResponse == DialogResult.OK)
            {
                using (DataContext context = new DataContext())
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    //selector:
                    var project = context.Projects.FirstOrDefault(p => p.ProjectId == projectID);

                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.Letter);
                            page.Margin(1, Unit.Inch);
                            page.PageColor(Colors.White);
                            page.DefaultTextStyle(x => x.FontSize(12));

                            //header
                            page.Header().Column(headerColumn =>
                            {
                                headerColumn.Item().Text($"Project Name: {project.ProjectName.ToString()}\n")
                                    .Bold().FontSize(16).AlignCenter();
                                headerColumn.Item()
                                    .Text("Project Tasks Report")
                                    .Bold().FontSize(14);
                            });

                            page.Content()
                                .Column(column1 =>
                                {
                                    column1.Spacing(10);
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("     1)");
                                        row.AutoItem()
                                            .Text(" Project Details:")
                                            .Bold();
                                    });
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("          a.");
                                        row.AutoItem()
                                            .Text(" Initiative:");
                                        row.RelativeItem()
                                            .Text(" " + $" {testStringEmpty(project.ProjectInitiative)}");
                                    });
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("          b.");
                                        row.AutoItem()
                                            .Text(" Start Date:");
                                        row.RelativeItem()
                                            .Text(" " + $" {testStringEmpty(project.ProjectStart)}");
                                    });
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("          c.");
                                        row.AutoItem()
                                            .Text(" End Date:");
                                        row.RelativeItem()
                                            .Text(" " + $" {testStringEmpty(project.ProjectEnd)}");
                                    });
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("          d.");
                                        row.AutoItem()
                                            .Text(" Project Manager:");
                                        row.RelativeItem()
                                            .Text(" " + $" {testStringEmpty(project.ProjectManager)}");
                                    });
                                    column1.Item().EnsureSpace().Column(column4 =>
                                    {
                                        column4.Item().Row(row =>
                                        {
                                            row.AutoItem()
                                                .Text("     2)");
                                            row.RelativeItem()
                                                .Text(" Assigned Resources List:")
                                                .Bold();
                                        });
                                        column4.Item().PaddingLeft(52).Table(table =>
                                        {
                                            table.ColumnsDefinition(tablColumns =>
                                            {
                                                tablColumns.RelativeColumn();
                                                tablColumns.RelativeColumn();
                                            });
                                            table.Header(header =>
                                            {
                                                header.Cell().Text("Name").Bold();
                                                header.Cell().Text("Description").Bold();
                                            });
                                            //get list of tasks by prjoect ID
                                            var tasksMatchProject = context.Tasks
                                                .Where(p => p.Task_ProjectId_FK == projectID).ToList();
                                            //get list of task IDs from list of tasks matching the project ID
                                            var taskIDList = tasksMatchProject.Select(p => p.TaskId).ToList();
                                            //get list of assignments by matching task IDs from task to assignedresources table
                                            var assignmentsMatchTaskIDList = context.AssignedResources
                                                .Where(p => taskIDList.Contains(p.TaskID_FK)).ToList();
                                            //get list of resource IDs ???
                                            var resourceIDList = assignmentsMatchTaskIDList.Select(p => p.ResourceID_FK).ToList();
                                            //get list of resources assigned to tasksff
                                            var resourceList = context.Resources //wtf I hope this works
                                                .Where(p => resourceIDList.Contains(p.ResourceId)).ToList();
                                            foreach (var resource in resourceList)
                                            {
                                                table.Cell().Border(1).Padding(3).Text(testStringEmpty(resource.ResourceName));
                                                table.Cell().Border(1).Padding(3).Text(testStringEmpty(resource.ResourceDescription));
                                            }
                                        });
                                    });
                                    column1.Item().EnsureSpace().Column(column5 =>
                                    {
                                        column5.Item().Row(row =>
                                        {
                                            row.AutoItem()
                                                .Text("     3)");
                                            row.AutoItem()
                                                .Text(" Sequenced Task List:")
                                                .Bold();
                                        });
                                        column5.Item().PaddingLeft(52).Table(table =>
                                        {
                                            table.ColumnsDefinition(tablColumns =>
                                            {
                                                tablColumns.RelativeColumn();//Task.Sequence ID
                                                tablColumns.RelativeColumn();//Task.Name
                                                tablColumns.RelativeColumn();//Task.Description
                                                tablColumns.RelativeColumn();//Resource assigned to task => Resource.Name
                                                tablColumns.RelativeColumn();//Task.Start Date
                                                tablColumns.RelativeColumn();//Task.End Date
                                                tablColumns.RelativeColumn();//Task.Completion
                                            });
                                            table.Header(header =>
                                            {
                                                header.Cell().Text("#").Bold().FontSize(10);
                                                header.Cell().Text("Task").Bold().FontSize(10);
                                                header.Cell().Text("Description").Bold().FontSize(10);
                                                header.Cell().Text("Assigned Resource").Bold().FontSize(10);
                                                header.Cell().Text("Start Date").Bold().FontSize(10);
                                                header.Cell().Text("End Date").Bold().FontSize(10);
                                                header.Cell().Text("Completion").Bold().FontSize(10);
                                            });
                                            //get list of tasks by prjoect ID
                                            var tasksMatchProject = context.Tasks
                                                .Where(p => p.Task_ProjectId_FK == projectID).ToList();
                                            //get list of task IDs from list of tasks matching the project ID
                                            var taskIDList = tasksMatchProject.Select(p => p.TaskId).ToList();
                                            //get list of assignments by matching task IDs from task to assignedresources table
                                            var assignmentsMatchTaskIDList = context.AssignedResources
                                                .Where(p => taskIDList.Contains(p.TaskID_FK)).ToList();
                                            //get resource IDs
                                            var resourceIDList = assignmentsMatchTaskIDList
                                                .Select(p => p.ResourceID_FK).ToList();
                                            //get names of resources
                                            var resourceList = context.Resources 
                                                .Where(p => resourceIDList.Contains(p.ResourceId)).ToList();
                                            //Dictionary implementation 
                                            var resourceDictionary = resourceList.ToDictionary(p => p.ResourceId, p => p.ResourceName);


                                            foreach (var task in tasksMatchProject)
                                            {
                                                var resourceNames = assignmentsMatchTaskIDList
                                                    .Where(p => p.TaskID_FK == task.TaskId)
                                                    .Select(p => resourceDictionary.ContainsKey(p.ResourceID_FK) ? resourceDictionary[p.ResourceID_FK] : "")
                                                    .ToList();

                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(task.SequenceID.ToString())}").FontSize(9);
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(task.TaskName)}").FontSize(9);
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(task.TaskDescription)}").FontSize(9);
                                                table.Cell().Border(1).Padding(3).Text(testStringEmpty(resourceNames.FirstOrDefault())).FontSize(9);
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(task.TaskStartDate)}").FontSize(9);
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(task.TaskEndDate)}").FontSize(9);
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(task.Completion.ToString())}").FontSize(9);
                                            }
                                        });
                                    });
                                });
                            page.Footer()
                            .AlignRight()
                            .Text(x =>
                            {
                                x.Span("Page ").FontSize(8);
                                x.CurrentPageNumber().FontSize(8);
                                x.Span("/").FontSize(8);
                                x.TotalPages().FontSize(8);
                            });
                        });
                    })
                    .GeneratePdf(saveFileDialog.FileName);
                }
                var openFileResponse = MessageBox.Show($"The file has been saved at:\n{saveFileDialog.FileName}\n\nWould you like to open the file?", "Project Charter Saved!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (openFileResponse == DialogResult.Yes) { Process.Start(new ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true }); } //idk, but it works
            }
            //.GeneratePdf(saveFileDialog.FileName);


        }
        public string testStringEmpty(string text)
        {
            string output;
            if (string.IsNullOrEmpty(text))
            {
                output = "";
            }
            else { output = text; }
            return output;
        }
    }
}
