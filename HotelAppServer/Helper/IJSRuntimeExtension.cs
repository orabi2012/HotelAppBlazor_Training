﻿using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelAppServer.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime IJSRuntime, string message)
        {
            await IJSRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async Task ToastrError(this IJSRuntime IJSRuntime, string message)
        {
            await IJSRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }
        public static async Task<bool> ShowConfirm(this IJSRuntime IJSRuntime)
        {
            return await IJSRuntime.InvokeAsync<bool>("confirm", "Are you sure?");
        }
    }
}
