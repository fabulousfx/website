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
                            prop.text Strings.Pages.Home.HeaderPane.Title
                        ]
                        Bulma.title.h2 [
                            prop.className "subtitle"
                            prop.text Strings.Pages.Home.HeaderPane.Subtitle
                        ]
                        Html.p [
                            prop.className "catchphrase"
                            prop.text Strings.Pages.Home.HeaderPane.CatchPhrase
                        ]
                        Html.div [
                                Bulma.button.button [
                                button.isRounded
                                color.isDanger
                                prop.className "gettings-started-button"
                                prop.text Strings.Pages.Home.HeaderPane.GettingStartedButton
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
                            Bulma.title.h3 Strings.Pages.Home.UpdateLogicPane.Title

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
                            Bulma.title.h3 Strings.Pages.Home.UIFlavorsPane.Title

                            Bulma.columns [
                                Bulma.column [
                                    column.isHalfWideScreen
                                    prop.children [
                                        Bulma.card [
                                            Bulma.cardHeader [
                                                Bulma.cardHeaderTitle.p [
                                                    cardHeaderTitle.isCentered
                                                    prop.text Strings.Pages.Home.UIFlavorsPane.DynamicViewsCardTitle
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
                                                    prop.text Strings.Pages.Home.UIFlavorsPane.StaticViewsCardTitle
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
                                Html.text Strings.Pages.Home.UIFlavorsPane.Footer
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
                            Bulma.title.h3 Strings.Pages.Home.UIFrameworksPane.Title

                            Bulma.columns [
                                Bulma.column [
                                    column.isHalf
                                    prop.children [
                                        Bulma.text.p "Images"
                                    ]
                                ]
                                Bulma.column [
                                    column.isHalf
                                    prop.children [
                                        Bulma.text.p "Choose from the supported platforms"
                                    ]
                                ]
                            ]

                            Html.div [
                                Html.text Strings.Pages.Home.UIFrameworksPane.FooterPart1
                                Html.a [
                                    prop.href Links.docs
                                    prop.text Strings.Pages.Home.UIFrameworksPane.FooterPart2
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
                            Bulma.title.h3 "See your changes without stopping the app"

                            Bulma.columns [
                                Bulma.column [
                                    column.isHalf
                                    prop.children [
                                        Bulma.text.p "Images"
                                    ]
                                ]
                                Bulma.column [
                                    column.isHalf
                                    prop.children [
                                        Bulma.text.p "Choose from the supported platforms"
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