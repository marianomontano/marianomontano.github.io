using Microsoft.JSInterop;

namespace BlazorCv.Services;

public static class JavascriptExtensions
{
    public static async Task SetLocalStorage(this IJSRuntime js, string value)
    {
        await js.InvokeVoidAsync($"blazorCulture.set", value);
    }

    public static async Task<string> GetLocalStorage(this IJSRuntime js)
    {
        return await js.InvokeAsync<string>("blazorCulture.get");
    }
}