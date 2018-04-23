<!DOCTYPE HTML>
<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />
    <script src="@Url.Content("~/Scripts/MicrosoftAjax.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/MicrosoftMvcValidation.js")" type="text/javascript"></script>
    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.All}
    )
    @Html.DevExpress().GetScripts(
        New Script With {.ExtensionSuite = ExtensionSuite.All}
    )
</head>
<body>
    @RenderBody()
</body>
</html>