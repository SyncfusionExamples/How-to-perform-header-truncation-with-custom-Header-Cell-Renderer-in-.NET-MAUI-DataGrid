# How to perform header truncation with custom Header Cell Renderer in .NET MAUI DataGrid

In this article, we will show you how to perform header truncation with custom HeaderCellRenderer in [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

XAML
```
    <syncfusion:SfDataGrid x:Name="dataGrid"
                           GridLinesVisibility="Both"
                           HeaderGridLinesVisibility="Both"
                           AutoGenerateColumnsMode="None"
                           ItemsSource="{Binding Employees}">
 
        <syncfusion:SfDataGrid.Columns>
            <syncfusion:DataGridTextColumn MappingName="Name"
                                           HeaderText="Customer Name" />
            <syncfusion:DataGridTextColumn MappingName="Title"
                                           HeaderText="Designation" />
            <syncfusion:DataGridDateColumn MappingName="BirthDate"
                                           HeaderText="Joining Date" />
            <syncfusion:DataGridTextColumn MappingName="Gender"
                                           HeaderText="Gender" />
 
        </syncfusion:SfDataGrid.Columns>
    </syncfusion:SfDataGrid>
 ```

C#
The below code illustrates how to perform header truncation with custom Header Cell renderer.
```
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        dataGrid.CellRenderers.Remove("ColumnHeader");
        dataGrid.CellRenderers.Add("ColumnHeader", new DataGridHeaderCellRendererExt());
    }
}
 
public class DataGridHeaderCellRendererExt : DataGridHeaderCellRenderer
{
    protected override void OnInitializeDisplayView(DataColumnBase dataColumn, SfDataGridContentView? view)
    {
        base.OnInitializeDisplayView(dataColumn, view);
 
        if (view!.Content is Grid headerView)
        {
            var label = headerView.Children.FirstOrDefault(child => child is SfDataGridHeaderLabel);
 
            if (label != null && label is SfDataGridHeaderLabel newLabel)
            {
                newLabel.LineBreakMode = LineBreakMode.CharacterWrap;
            }
        }
    }
}
```
 ![HeaderTruncation.png](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0OTk3Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.eyZfIABjlx2oxMGwnvlxdmzB6ZOP70D9yS3U48zGMoo)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-perform-header-truncation-with-custom-Header-Cell-Renderer-in-.NET-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to perform header truncation with custom HeaderCellRenderer in .NET MAUI DataGrid.
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!