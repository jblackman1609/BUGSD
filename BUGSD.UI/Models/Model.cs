using DocumentFormat.OpenXml.InkML;

namespace BUGSD.UI.Models;

public abstract class Model
{
    public string Id { get; protected set; }
    public DateTime CreatedAt { get; protected set; }

    protected Model(string id, DateTime createdAt) => (Id, CreatedAt) = (id, createdAt);
}