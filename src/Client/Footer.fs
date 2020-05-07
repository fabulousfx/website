namespace FabulousWebsite.Client

open Feliz
open Feliz.Bulma

module Footer =
    let view () =
        Bulma.footer [
            color.isDanger
            prop.style [ style.paddingBottom 48 ]
            prop.children [
                Bulma.columns [
                    columns.isCentered
                    prop.children [
                        Bulma.column [
                            column.isNarrow
                            prop.children [
                                Bulma.image [
                                    Html.img [
                                        prop.src Assets.logoSvg
                                        prop.style [ style.width 200 ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]