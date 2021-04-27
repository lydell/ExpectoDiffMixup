module ExpectoDiffMixup
open Expecto

Expect.defaultDiffPrinter <- Diff.colourisedDiff

[<EntryPoint>]
let main argv =
    Tests.runTestsInAssembly defaultConfig argv
