namespace Danielson.Components.Pages {

    public partial class Home {
        protected string Information { get; set; } = "";

        public async Task<bool> ClickMe() {
            _ = await Task.Run(() => Information = "Testing click button");
            StateHasChanged();
            return true;
        }

        private void UpdateHeading() {
            Information = $"New heading ({DateTime.Now})";
        }
    }
}