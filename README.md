
---

# Blazor UI Libraries: A Comparative Analysis

With numerous BlazorUI libraries available, developers often struggle to choose the right one.

One crucial factor in this decision is file size. A smaller file size not only reduces the initial download time but also speeds up the initialization process every time the app starts.

This is particularly important for low- and mid-end mobile devices, where limited CPU power and bandwidth can significantly impact performance.

The table below provides an overview of the file sizes of various popular Blazor UI libraries:

| Library                                                         | File Size | Diff     |
|-----------------------------------------------------------------|-----------|----------|
| **Blazor only**                                                 | 1.5 MB    | N/A	     |
| [**bit BlazorUI**](https://blazorui.bitplatform.dev/)			  | 1.7 MB    | +0.2 MB  |
| [**MudBlazor**](https://mudblazor.com/)                         | 2.0 MB    | +0.5 MB  |
| [**MatBlazor**](https://matblazor.com/)						  | 2.1 MB    | +0.6 MB  |
| [**LumexUI**](https://lumexui.org/)							  | 2.5 MB    | +1.0 MB  |
| [**Blazorise**](https://blazorise.com/)                         | 3.1 MB    | +1.6 MB  |
| [**Ant Design**](https://antblazor.com/)                        | 3.6 MB    | +2.1 MB  |
| [**Syncfusion**](https://syncfusion.com/blazor-components/)	  | 4.3 MB    | +2.8 MB  |
| [**Telerik**](https://telerik.com/blazor-ui/)					  | 7.7 MB    | +6.2 MB  |
| [**Radzen**](https://blazor.radzen.com/)                        | 9.1 MB    | +7.6 MB  |
| [**DevExpress**](https://devexpress.com/blazor/)				  | 13.5 MB   | +12.0 MB |

The comparison above is based on the WASM, JS, and CSS files required to utilize **5 components** from each of the mentioned libraries.

---

If a page with 5 components takes up 1.7MB, it doesn't mean a fully built website will scale linearly to 5MB!
For instance, the https://bitplatform.dev website, which includes over 40 pages, numerous components, and both dark and light themes,
is only 2.5MB. While the runtime and libraries contribute to the initial download size, adding more pages to the project doesn’t significantly increase the overall web app size.
