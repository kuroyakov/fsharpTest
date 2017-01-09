module Tests

open Expecto
open testLib
[<Tests>]
let tests =
  testList "samples" [
    testCase "universe exists" <| fun _ ->
      let subject = true
      Expect.isTrue subject "I compute, therefore I am."

    testCase "call lib method" <| fun _ ->
      let subject = testLib().X
      Expect.equal subject "F#" ""
  ]