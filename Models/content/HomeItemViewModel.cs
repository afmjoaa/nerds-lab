namespace nerds_lab.Models;

public class HomeItemViewModel
{
    // Defines the properties of the view model
    public string HomeItemTitle { get; set; }
    public string HomeItemDescription { get; set; }
    public string HomeItemProgressText { get; set; }
    public string HomeItemPageLink { get; set; }
    public int HomeItemProgressPercentage { get; set; }
    public int HomeItemProgressColor { get; set; }
}