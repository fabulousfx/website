namespace FabulousWebsite.Client

open Fable.FontAwesome
open Feliz
open Feliz.Bulma

module Navbar =
    let view () =
        Bulma.navbar [
            navbar.isTransparent
            prop.children [
                Bulma.navbarBrand.div [
                    Bulma.navbarItem.a [
                        prop.href "#"
                        prop.children [
                            Html.img [
                                prop.style [ style.width 130 ]
                                prop.src "assets/logo.svg"
                            ]
                        ]
                    ]
                ]

                Bulma.navbarEnd.div [
                    Bulma.navbarItem.div [
                        navbarItem.hasDropdown
                        navbarItem.isHoverable
                        prop.children [
                            Bulma.navbarLink.a [
                                navbarLink.isArrowless
                                prop.href "/docs"
                                prop.text "Docs"
                            ]

                            Bulma.navbarDropdown.div [
                                Bulma.navbarItem.a [
                                    prop.href "/docs/Fabulous"
                                    prop.text "Fabulous"
                                ]
                                Bulma.navbarDivider []
                                Bulma.navbarItem.a [
                                    prop.href "/docs/Fabulous.XamarinForms"
                                    prop.text "Fabulous for Xamarin.Forms"
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.href "/showcase"
                        prop.text "Showcase"
                    ]

                    Bulma.navbarItem.a [
                        prop.href "/community"
                        prop.text "Community"
                    ]

                    Bulma.navbarItem.a [
                        prop.children [
                            Bulma.icon [
                                prop.children [
                                    Fa.i [ Fa.Solid.Search ] []
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.href Links.Github
                        prop.children [
                            Bulma.icon [
                                prop.children [
                                    Fa.i [ Fa.Brand.Github ] []
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.href Links.Gitter
                        prop.children [
                            Bulma.icon [
                                prop.children [
                                    Fa.i [ Fa.Brand.Gitter ] []
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.href Links.Slack
                        prop.children [
                            Bulma.icon [
                                prop.children [
                                    Fa.i [ Fa.Brand.Slack ] []
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.div [
                        Bulma.button.a [
                            prop.href "/getting-started"
                            prop.text "Get started"
                        ]
                    ]
                ]
            ]
        ]
