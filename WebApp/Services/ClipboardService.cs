﻿using ApplicationCore.Interfaces;
using Microsoft.JSInterop;

namespace WebApp.Services
{
    public class ClipboardService : IClipboardService
    {
        private readonly IJSRuntime _jsInterop;
        public ClipboardService(IJSRuntime jsInterop)
        {
            _jsInterop = jsInterop;
        }

        public async Task CopyTextToClipboard(string text)
        {
            await _jsInterop.InvokeVoidAsync("navigator.clipboard.writeText", text);
        }
    }
}
