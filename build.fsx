// include Fake libs
#r "./packages/FAKE/tools/FakeLib.dll"

open Fake
open Fake.Testing.Expecto

// Directories
let buildDir  = "./build/"
let deployDir = "./deploy/"


// Filesets
let appReferences  =
    !! "/**/*.csproj"
    ++ "/**/*.fsproj"

let testExecutables =
    !! (buildDir + "/**/*Test.exe")

// Targets
Target "Clean" (fun _ ->
    CleanDirs [buildDir; deployDir]
)

Target "Build" (fun _ ->
    // compile all projects below src/app/
    MSBuildDebug buildDir "Build" appReferences
    |> Log "AppBuild-Output: "
)

Target "Deploy" (fun _ ->
    !! (buildDir + "/**/*.*")
    -- "*.zip"
    |> Zip buildDir (deployDir + "TestLib.zip")
)

// For Unit Test by using Expecto
Target "RunTests" (fun _ ->
    testExecutables
    |> Expecto (fun p -> { p with Parallel = false } )
    |> ignore
)

// Build order
"Clean"
  ==> "Build"
  ==> "RunTests"
  ==> "Deploy"

// start build
RunTargetOrDefault "Build"
