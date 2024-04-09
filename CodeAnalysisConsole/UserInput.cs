using System.Text;

namespace CodeGen;

public class UserInput
{
    private readonly List<string> _inputList;
    private string Input { get; set; }

    public UserInput(string userInput)
    {
        _inputList = userInput.Split(",").ToList();
    }

    public bool ShouldGenerateDtos => _inputList.Contains("d")|| ShouldGenerateAllLayers;
    public bool ShouldGenerateCommandOrQueries => _inputList.Contains("c") || ShouldGenerateAllLayers;
    // public bool ShouldGenerateQueries => _inputList.Contains("query");
    public bool ShouldGenerateCommandOrQueryHandlers => _inputList.Contains("h") || ShouldGenerateAllLayers;
    
    public bool ShouldGenerateValidators => _inputList.Contains("v") || ShouldGenerateAllLayers;

    // public bool ShouldGenerateQueryHandlers => _inputList.Contains("queryhandler");
    public bool ShouldGenerateAllLayers => _inputList.Contains("layers");
    public bool ShouldGenerateAllVerbs => _inputList.Contains("verbs") ;
    
    public bool ShouldGenerateCreate => _inputList.Contains("create") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateGet => _inputList.Contains("get") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateGetList => _inputList.Contains("getlist") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateDelete => _inputList.Contains("delete") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateUpdate => _inputList.Contains("update") || ShouldGenerateAllVerbs;
    
    public bool HasAtLeastOneCommandOrQuery => 
        (ShouldGenerateCreate || ShouldGenerateGet || ShouldGenerateGetList || ShouldGenerateDelete || ShouldGenerateUpdate)
    && (ShouldGenerateCommandOrQueries || ShouldGenerateCommandOrQueryHandlers || ShouldGenerateAllLayers || ShouldGenerateDtos)
         ;

    public static string CommandList()
    {
        var sb = new StringBuilder();
        sb.Append(@"
d=dto
c=command or query
h=command or query handler
v=validator
layers=all layers
verbs=all verbs
create=create
get=get
getlist=getlist
delete=delete
update=update
");
        return sb.ToString();
    }

}