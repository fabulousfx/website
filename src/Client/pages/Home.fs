namespace FabulousWebsite.Client.Pages

open Feliz
open Feliz.Bulma
open Feliz.Markdown
open Feliz.Markdown.SyntaxHighlighter
open FabulousWebsite.Client

module Home =
    let updateSample = @"
```fsharp
type Model = { Count: int }
type Msg =
    | Increment
    | Decrement

let init () = { Count = 0 }

let update msg model =
    match msg with
    | Increment ->
        { model with Count = model.Count + 1 }
    | Decrement ->
        { model with Count = model.Count - 1 }
```"

    let dynamicViewsSample = @"
```fsharp
let view model dispatch =
    ContentPage(
        StackLayout([
            Image(source = ImagePath ""fabulous.png"")
            Label(fontSize = FontSize 22., text = model.Count.ToString())
            Button(
                text = ""+"",
                command = fun () -> dispatch Increment
            )
            Button(
                text = ""-"",
                command = fun () -> dispatch Decrement
            )
        ])
    )
```"

    let staticViewsSample = @"
```fsharp
let view model dispatch =
    Component(
        MainPage,
        {| Count = Binding.oneWay model.Count
           IncrementCommand = Command.msg Increment
           DecrementCommand = Command.msg Decrement |}
    )
```
----------
```xml
<ContentPage (...) x:Class=""MyApp.MainPage"">
    <StackLayout>
        <Image Source=""fabulous.png"" />
        <Label FontSize=""22"" Text=""{Binding Count}"" />
        <Button Text=""+"" Command=""{Binding IncrementCommand}"" />
        <Button Text=""-"" Command=""{Binding DecrementCommand}"" />
    </StackLayout>
</ContentPage>
```"

    let headerPane () =
        Bulma.hero [
            hero.isMedium
            color.isSuccess
            prop.children [
                Bulma.heroBody [
                    text.hasTextCentered
                    prop.children [
                        Bulma.title.h1 [
                            title.isSpaced
                            prop.className "title"
                            prop.text Strings.Pages.Home.HeaderPane.title
                        ]
                        Bulma.title.h2 [
                            prop.className "subtitle"
                            prop.text Strings.Pages.Home.HeaderPane.subtitle
                        ]
                        Html.p [
                            prop.className "catchphrase"
                            prop.text Strings.Pages.Home.HeaderPane.catchPhrase
                        ]
                        Html.div [
                                Bulma.button.button [
                                button.isRounded
                                color.isDanger
                                prop.className "gettings-started-button"
                                prop.text Strings.Pages.Home.HeaderPane.gettingStartedButton
                            ]
                        ]
                    ]
                ]
            ]
        ]
        
    let updateLogicPane () =
        Bulma.hero [
            color.isLight
            prop.children [
                Bulma.heroBody [
                    Bulma.container [
                        container.isFluid
                        text.hasTextCentered
                        prop.children [
                            Bulma.title.h3 Strings.Pages.Home.UpdateLogicPane.title

                            Bulma.columns [
                                columns.isCentered
                                prop.children [
                                    Bulma.column [
                                        column.isNarrow
                                        prop.children [
                                            Bulma.card [
                                                Bulma.cardContent [
                                                    Markdown.markdown [
                                                        markdown.renderers [
                                                            SyntaxHighlighter.prism "coy"
                                                        ]
                                                        markdown.source updateSample
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    let uiFlavorsPane () =
        Bulma.hero [
            color.isDark
            prop.children [
                Bulma.heroBody [
                    Bulma.container [
                        container.isFluid
                        text.hasTextCentered
                        prop.children [
                            Bulma.title.h3 Strings.Pages.Home.UIFlavorsPane.title

                            Bulma.columns [
                                Bulma.column [
                                    column.isHalfWideScreen
                                    prop.children [
                                        Bulma.card [
                                            Bulma.cardHeader [
                                                Bulma.cardHeaderTitle.p [
                                                    cardHeaderTitle.isCentered
                                                    prop.text Strings.Pages.Home.UIFlavorsPane.dynamicViewsCardTitle
                                                ]
                                            ]
                                            Bulma.cardContent [
                                                Markdown.markdown [
                                                    markdown.renderers [
                                                        SyntaxHighlighter.prism "coy"
                                                    ]
                                                    markdown.source dynamicViewsSample
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Bulma.column [
                                    column.isHalfWideScreen
                                    prop.children [
                                        Bulma.card [
                                            Bulma.cardHeader [
                                                Bulma.cardHeaderTitle.p [
                                                    cardHeaderTitle.isCentered
                                                    prop.text Strings.Pages.Home.UIFlavorsPane.staticViewsCardTitle
                                                ]
                                            ]
                                            Bulma.cardContent [
                                                Markdown.markdown [
                                                    markdown.renderers [
                                                        SyntaxHighlighter.prism "coy"
                                                    ]
                                                    markdown.source staticViewsSample
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]

                            Html.div [
                                Html.text Strings.Pages.Home.UIFlavorsPane.footer
                            ]
                        ]
                    ]
                ]
            ]
        ]

    let uiFrameworksPane () =
        Bulma.hero [
            color.isLight
            prop.children [
                Bulma.heroBody [
                    Bulma.container [
                        container.isFluid
                        text.hasTextCentered
                        prop.children [
                            Bulma.title.h3 Strings.Pages.Home.UIFrameworksPane.title

                            Bulma.columns [
                                columns.isCentered
                                columns.isVCentered
                                prop.children [
                                    Bulma.column [
                                        prop.children [
                                            Bulma.image [
                                                prop.className "framework-logo"
                                                helpers.isInlineBlock
                                                prop.children [
                                                    Html.img [
                                                        prop.src Assets.xamarinFormsPng
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                    Bulma.column [
                                        prop.children [
                                            Bulma.image [
                                                prop.className "framework-logo"
                                                helpers.isInlineBlock
                                                prop.children [
                                                    Html.img [
                                                        prop.src Assets.unoPlatformPng
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                    Bulma.column [
                                        prop.children [
                                            Bulma.image [
                                                prop.className "framework-logo"
                                                helpers.isInlineBlock
                                                prop.children [
                                                    Html.img [
                                                        prop.src Assets.wpfPng
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                            ]

                            Html.div [
                                Html.p Strings.Pages.Home.UIFrameworksPane.footerPart1
                                Html.a [
                                    prop.href Links.docs
                                    prop.text Strings.Pages.Home.UIFrameworksPane.footerPart2
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    let liveUpdatePane () =
        Bulma.hero [
            color.isDark
            prop.children [
                Bulma.heroBody [
                    Bulma.container [
                        container.isFluid
                        text.hasTextCentered
                        prop.children [
                            Bulma.title.h3 "Save time with LiveUpdate"

                            Bulma.columns [
                                columns.isCentered
                                columns.isVCentered
                                prop.children [
                                    Bulma.column [
                                        column.isHalf
                                        prop.children [
                                            Bulma.media [
                                                Html.video [
                                                    prop.controls true
                                                    prop.children [
                                                        Html.source [
                                                            prop.src Assets.liveUpdateMov
                                                            prop.type' Assets.liveUpdateMovMediaType
                                                        ]
                                                    ]
                                                ]
                                            ]
                                        ]
                                    ]
                                    Bulma.column [
                                        prop.children [
                                            Bulma.text.p "You don't need to restart the app anymore to see your changes."
                                            Bulma.text.p "LiveUpdate will recompile your code when saving, and automatically reload the app while it's running."
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    let view () =
        Html.div [
            headerPane ()
            updateLogicPane ()
            uiFlavorsPane ()
            uiFrameworksPane ()
            liveUpdatePane ()
        ]