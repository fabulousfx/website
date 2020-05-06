namespace FabulousWebsite.Client

open Elmish

module Program =
    /// Typical program, new commands are produced discriminated unions returned by `init` and `update` along with the new state.
    let mkProgramWithCmdMsg
        (init: 'arg -> 'model * 'cmdMsg list)
        (update: 'msg -> 'model -> 'model * 'cmdMsg list)
        (view: 'model -> Dispatch<'msg> -> 'view) (mapToCmd: 'cmdMsg -> Cmd<'msg>) =
        
        let convert = fun (model, cmdMsgs) -> model, (cmdMsgs |> List.map mapToCmd |> Cmd.batch)
        Program.mkProgram (init >> convert) (fun msg model -> update msg model |> convert) view