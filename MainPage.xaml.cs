namespace FunkyAsyncAnimations;

using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async Task Animate()
    {
        var start = DateTime.Now;
        await DotNetBotImage.RotateTo(45, 500);
        await DotNetBotImage.RotateTo(0, 500);
        var animationTime = DateTime.Now - start;
        CounterBtn.Text = $"Animation lasted {animationTime.TotalMilliseconds} ms";
    }
    private void OnAnimatClicked(object sender, EventArgs e)
    {
        Animate();
    }
}