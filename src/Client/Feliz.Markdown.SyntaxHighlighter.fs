namespace Feliz.Markdown.SyntaxHighlighter

open Fable.Core.JsInterop
open Feliz
open Feliz.Markdown

type SyntaxHighlighter =
    static member inline prism (style: string) =
        markdown.renderers.code
            (fun codeProperties ->
                let props = [
                    "language" ==> codeProperties.language
                    "style" ==> import style "react-syntax-highlighter/dist/esm/styles/prism"
                    "children" ==> codeProperties.value
                ]
                Interop.reactApi.createElement(import "Prism" "react-syntax-highlighter", createObj !!props))
    