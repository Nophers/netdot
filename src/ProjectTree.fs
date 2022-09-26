namespace ProjectTree

module TreeModule =

    open System;

    let getAllFiles() =
        let files: string[] = System.IO.Directory.GetFiles(
            Environment.CurrentDirectory, "*.fs", IO.SearchOption.AllDirectories);
        files;

    let getAmount() =
        let files: string[] = getAllFiles();
        let amount: int = files.Length;
        printfn "Amount of files: %d" amount;

    let printTree() =
        let files: string[] = getAllFiles();
        files |> Array.iter (fun (file: string) -> printfn "%s" file);

        getAmount();

    let main() =
        printTree();

    main();
