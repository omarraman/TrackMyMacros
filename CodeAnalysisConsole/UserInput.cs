using System.Text;

namespace CodeGen;

public class UserInput
{
    private readonly List<string> _inputList;

    public UserInput(string userInput)
    {
        _inputList = userInput.Split(",").ToList();
    }

    public bool ShouldGenerateDtos => _inputList.Contains("d") || ShouldGenerateAllLayers;

    public bool ShouldGenerateCommandOrQueries => _inputList.Contains("c") || ShouldGenerateAllLayers;

    // public bool ShouldGenerateQueries => _inputList.Contains("query");
    public bool ShouldGenerateCommandOrQueryHandlers => _inputList.Contains("h") || ShouldGenerateAllLayers;

    public bool ShouldGenerateControllers => _inputList.Contains("ctl") || ShouldGenerateAllLayers;
    public bool ShouldGenerateValidators => _inputList.Contains("v") || ShouldGenerateAllLayers;
    public bool ShouldGenerateMappings => _inputList.Contains("m") || ShouldGenerateAllLayers;
    public bool ShouldGenerateViewModelMappings => _inputList.Contains("vmm") || ShouldGenerateAllLayers;
    public bool ShouldGenerateDataServices => _inputList.Contains("ds") || ShouldGenerateAllLayers;
    public bool ShouldGenerateRepositories => _inputList.Contains("r") || ShouldGenerateAllLayers;
    public bool ShouldGenerateDialog => _inputList.Contains("dlg") || ShouldGenerateAllLayers;
    public bool ShouldGenerateUiAddPage => _inputList.Contains("ui_add") || ShouldGenerateAllLayers;
    public bool ShouldGenerateViewModel => _inputList.Contains("vm") || ShouldGenerateAllLayers;

    // public bool ShouldGenerateQueryHandlers => _inputList.Contains("queryhandler");
    public bool ShouldGenerateAllLayers => _inputList.Contains("layers");
    public bool ShouldGenerateAllVerbs => _inputList.Contains("verbs");

    public bool ShouldGenerateCreate => _inputList.Contains("create") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateGet => _inputList.Contains("get") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateGetList => _inputList.Contains("getlist") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateDelete => _inputList.Contains("delete") || ShouldGenerateAllVerbs;
    public bool ShouldGenerateUpdate => _inputList.Contains("update") || ShouldGenerateAllVerbs;

    public bool HasAtLeastOneCommandOrQuery =>
        (ShouldGenerateCreate || ShouldGenerateGet || ShouldGenerateGetList || ShouldGenerateDelete ||
         ShouldGenerateUpdate)
        && (ShouldGenerateCommandOrQueries || ShouldGenerateCommandOrQueryHandlers || ShouldGenerateAllLayers ||
            ShouldGenerateDtos);

    public static string CommandList()
    {
        var sb = new StringBuilder();
        sb.Append(@"
d=dto
c=command or query
h=command or query handler
v=validator
m=mapping
vmm=view model mapping,
ctl=controller,
ds=data service,
layers=all layers
verbs=all verbs
create=create
get=get
getlist=getlist
delete=delete
update=update
dlg=dialog,
r=repository,
ui_add=ui add entity page,
");
        return sb.ToString();
    }
}