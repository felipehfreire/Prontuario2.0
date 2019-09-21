namespace H1.Services.ViewModel.Select2
{
    public class ResultS2ViewModel
    {
        public string id { get; set; }
        public string text { get; set; }
        public string InfoExtra { get; set; }

        public ResultS2ViewModel()
        {

        }

        public ResultS2ViewModel(string id, string text, string InfoExtra = "")
        {
            this.id = id;
            this.text = text;
            this.InfoExtra = InfoExtra;
        }
    }
}
