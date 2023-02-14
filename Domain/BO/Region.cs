using JobChannel.Domain.Base;

namespace JobChannel.Domain.BO;

public record Region : BaseEntity<int>
{
    public string Name { get; set; }
    public string Code { get; set; }

    public Region() : base(-1)
    {
        Name = string.Empty;
        Code = string.Empty;
    }

    public Region(int id, string name, string codeRome) : base(id)
    {
        Name = name;
        Code = codeRome;
    }
}
