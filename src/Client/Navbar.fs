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
                        prop.href Links.root
                        prop.children [
                            Html.img [
                                prop.style [ style.width 130 ]
                                prop.src Assets.logoSvg
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
                                prop.href Links.docs
                                prop.text Strings.Navbar.Docs
                            ]

                            Bulma.navbarDropdown.div [
                                Bulma.navbarItem.a [
                                    prop.href Links.Docs.fabulous
                                    prop.text Strings.Navbar.DocsFabulous
                                ]
                                Bulma.navbarDivider []
                                Bulma.navbarItem.a [
                                    prop.href Links.Docs.fabulousXamarinForms
                                    prop.text Strings.Navbar.DocsFabulousXamarinForms
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.href Links.showcase
                        prop.text Strings.Navbar.Showcase
                    ]

                    Bulma.navbarItem.a [
                        prop.href Links.community
                        prop.text Strings.Navbar.Community
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
                        prop.title Strings.Navbar.GitHub
                        prop.href ExternalLinks.github
                        prop.children [
                            Bulma.icon [
                                prop.children [
                                    Fa.i [ Fa.Brand.Github ] []
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.title Strings.Navbar.Gitter
                        prop.href ExternalLinks.gitter
                        prop.children [
                            Bulma.icon [
                                prop.children [
                                    Fa.i [ Fa.Brand.Gitter ] []
                                ]
                            ]
                        ]
                    ]

                    Bulma.navbarItem.a [
                        prop.title Strings.Navbar.Slack
                        prop.href ExternalLinks.slack
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
                            prop.href Links.gettingStarted
                            prop.text Strings.Navbar.GetStarted
                        ]
                    ]
                ]
            ]
        ]
