module Tests

open Expecto

[<Tests>]
let tests =
  testList "samples" [
    testCase "diff" <| fun _ ->
      Expect.equal "actual text" "expected text" ""

    testCase "color" <| fun _ ->
      Expect.equal "some actual text" "some expected text" ""
  ]
