module Other

open Xunit

[<Fact>]
let ``test diff`` () =
  Expecto.Diff.equals "actual text" "expected text" ""

[<Fact>]
let ``test color`` () =
  Expecto.Diff.equals "some actual text" "some expected text" ""
