module FabulousWebsite.Client

open Elmish
open Elmish.React
open Fable.FontAwesome
open Feliz
open Feliz.Bulma
open Feliz.Markdown
open FabulousWebsite.Client

type Model = NoModel

type Msg = NoMsg

type CmdMsg = NoCmdMsg

let mapToCmd cmdMsg =
    Cmd.none

let init () =
    NoModel, []

let update msg model =
    model, []

let view model dispatch =
    Html.body [
        Navbar.view ()

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
                            prop.text "Fabulous"
                        ]
                        Bulma.title.h2 [
                            prop.className "subtitle"
                            prop.text "F# Functional App Development"
                        ]
                        Html.p [
                            prop.className "hero-subtitle"
                            prop.text "Build native cross-platform apps using the ultra-simple Model-View-Update architecture and functional programming"
                        ]
                        Html.div [
                            Bulma.button.button [
                                button.isRounded
                                color.isDanger
                                prop.className "get-started-button"
                                prop.text "Start with Fabulous for Xamarin.Forms"
                            ]
                        ]
                    ]
                ]
            ]
        ]

        Bulma.hero [
            color.isLight
            prop.children [
                Bulma.heroBody [
                    Bulma.container [
                        container.isFluid
                        text.hasTextCentered
                        prop.children [
                            Bulma.title.h3 "Choose your flavor"

                            Bulma.columns [
                                Bulma.column [
                                    column.isOneThird
                                    prop.children [
                                        Bulma.card [
                                            Bulma.cardHeader [
                                                Bulma.cardHeaderTitle.p [
                                                    cardHeaderTitle.isCentered
                                                    prop.text "Dynamic UI"
                                                ]
                                            ]
                                            Bulma.cardContent [
                                                Markdown.markdown [
                                                    markdown.source "# This is a header\n\nAnd this is a paragraph"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Bulma.column [
                                    column.isOneThird
                                    prop.children [
                                        Bulma.card [
                                            Bulma.cardHeader [
                                                Bulma.cardHeaderTitle.p [
                                                    cardHeaderTitle.isCentered
                                                    prop.text "Static UI"
                                                ]
                                            ]
                                            Bulma.cardContent [
                                                Markdown.markdown [
                                                    markdown.source "# This is a header\n\nAnd this is a paragraph"
                                                ]
                                            ]
                                        ]
                                    ]
                                ]
                                Bulma.column [
                                    column.isOneThird
                                    prop.children [
                                        Bulma.card [
                                            Bulma.cardHeader [
                                                Bulma.cardHeaderTitle.p [
                                                    cardHeaderTitle.isCentered
                                                    prop.text "Adaptive UI"
                                                ]
                                            ]
                                            Bulma.cardContent [
                                                Markdown.markdown [
                                                    markdown.source "# This is a header\n\nAnd this is a paragraph"
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

        Bulma.hero [
            color.isDark
            prop.children [
                Bulma.heroBody [
                    Bulma.container [
                        container.isFluid
                        text.hasTextCentered
                        prop.children [
                            Bulma.title.h3 "Choose your UI framework"

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

                            Bulma.text.p "Don't see your favorite framework? Learn how to add support for Fabulous"
                        ]
                    ]
                ]
            ]
        ]

        Bulma.hero [
            color.isLight
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
    ]

#if DEBUG
open Elmish.Debug
open Elmish.HMR
#endif

Program.mkProgramWithCmdMsg init update view mapToCmd
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactBatched "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
