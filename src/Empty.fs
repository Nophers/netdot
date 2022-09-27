namespace EmptyStuff

module EmptyModule =

    open System;

    let getEmptyFolders() =
        let folders: string[] = System.IO.Directory.GetDirectories(
            Environment.CurrentDirectory, "*", IO.SearchOption.AllDirectories);
        folders;

    let getEmptyFiles() =
        let files: string[] = System.IO.Directory.GetFiles(
            Environment.CurrentDirectory, "*", IO.SearchOption.AllDirectories);
        files;

    let printEmptyStuff() = 
        let emptyFolders: string[] = getEmptyFolders();
        let emptyFiles: string[] = getEmptyFiles();
        printfn "Empty folders: %A" emptyFolders;
        printfn "Empty files: %A" emptyFiles;

    let main() = 
       printEmptyStuff()

    main();
