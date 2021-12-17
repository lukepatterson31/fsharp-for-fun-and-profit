open System
open System.IO
open System.Text.Json

type Node = {
    Name: string
    Value: int
    Children: Node List
}

let serializer (node: Node) = JsonSerializer.Serialize(node, options=JsonSerializerOptions(WriteIndented=true))

let writeToFile (strToWrite: string) =
    File.WriteAllText("../../../data/simpleNode.json", strToWrite)
        
let root = {
    Name="root"
    Value=2
    Children=[{
        Name="Child"
        Value=22
        Children=[]
    }]
}

root |> serializer |> writeToFile        