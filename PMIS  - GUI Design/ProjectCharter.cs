using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PMIS____GUI_Design
{
    public class ProjectCharter(int projectID)
    {
        int projectID = projectID;
        public void WritePDF()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.Title = "Save the Project Charter";
            var dialogResponse = saveFileDialog.ShowDialog();

            if(dialogResponse == DialogResult.OK)
            {
                using (DataContext context = new DataContext())
                {
                    QuestPDF.Settings.License = LicenseType.Community;

                    //selectors:
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
                                    .Text("Project Charter")
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
                                        row.RelativeItem()
                                            .Text(" Requirements:");
                                    });
                                    //get list of requirements
                                    var requirementsMatchProject = context.Requirements
                                        .Where(p => p.Requirement_ProjectId_FK == projectID).ToList();
                                    column1.Item().Column(column2 =>
                                    {
                                        int reqNumList = 1;
                                        foreach (var requirement in requirementsMatchProject)
                                        {
                                            column2.Item().PaddingLeft(52).PaddingRight(52)
                                                .Text($"{reqNumList}) " + $"{testStringEmpty(requirement.RequirementName)}: {testStringEmpty(requirement.RequirementDescr)}");
                                            reqNumList++; //~*~aRcAnE nUmBeR mAgIc~*~
                                        }
                                    });
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("          e.");
                                        row.RelativeItem()
                                            .Text(" Description:");
                                    });
                                    column1.Item().Column(column3 =>
                                    {
                                        column3.Item().PaddingLeft(52).PaddingRight(52)
                                            .Text($"{testStringEmpty(project.ProjectDescr)}");
                                    });
                                    column1.Item().Row(row =>
                                    {
                                        row.AutoItem()
                                            .Text("          f.");
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
                                                .Text(" Stakeholders List:")
                                                .Bold();
                                        });
                                        column4.Item().PaddingLeft(52).Table(table =>
                                        {
                                            table.ColumnsDefinition(tablColumns =>
                                            {
                                                tablColumns.RelativeColumn();
                                                tablColumns.RelativeColumn();
                                                tablColumns.RelativeColumn();
                                            });
                                            table.Header(header =>
                                            {
                                                header.Cell().Text("Name").Bold();
                                                header.Cell().Text("Title").Bold();
                                                header.Cell().Text("Role").Bold();
                                            });
                                            //get list of assignments by prjoect ID
                                            var assignmentsMatchProject = context.AssignedStakeholders
                                                .Where(p => p.ProjectID_FK == projectID).ToList();
                                            //get list of stakeholder IDs from list of assignmtnes matching the project ID
                                            var stkhldrIDList = assignmentsMatchProject.Select(p => p.StakeholderID_FK).ToList();
                                            //get list of stakeholders by matching stakeholder IDs from assignments to stakeholder table
                                            var stakeholdersMatchProject = context.Stakeholders
                                                .Where(p => stkhldrIDList.Contains(p.StakeholderID));
                                            foreach (var stkhldr in stakeholdersMatchProject)
                                            {
                                                table.Cell().Border(1).Padding(3).Text(testStringEmpty(stkhldr.StakeholderName));
                                                table.Cell().Border(1).Padding(3).Text(testStringEmpty(stkhldr.StakeholderTitle));
                                                table.Cell().Border(1).Padding(3).Text(testStringEmpty(stkhldr.StakeholderRole));
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
                                                .Text(" Milestone Schedule:")
                                                .Bold();
                                        });
                                        column5.Item().PaddingLeft(52).Table(table =>
                                        {
                                            table.ColumnsDefinition(tablColumns =>
                                            {
                                                tablColumns.RelativeColumn();
                                                tablColumns.RelativeColumn();
                                            });
                                            table.Header(header =>
                                            {
                                                header.Cell().Text("Name").Bold();
                                                header.Cell().Text("Date").Bold();
                                            });
                                            //milestone list
                                            var milestonesMatchProject = context.Milestones
                                                .Where(p => p.Milestone_ProjectId_FK == projectID).ToList();
                                            foreach (var milestone in milestonesMatchProject)
                                            {
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(milestone.MilestoneName)}");
                                                table.Cell().Border(1).Padding(3).Text($"{testStringEmpty(milestone.MilestoneDate)}");
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
                if(openFileResponse == DialogResult.Yes) { Process.Start(new ProcessStartInfo(saveFileDialog.FileName) { UseShellExecute = true }); } //idk, but it works
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