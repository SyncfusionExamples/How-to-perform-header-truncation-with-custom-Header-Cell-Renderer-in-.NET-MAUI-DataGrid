using Syncfusion.Maui.DataGrid;

namespace SfDataGridSample
{
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

}
