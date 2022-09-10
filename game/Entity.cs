

namespace game
{

public enum ComId
{
	Invalid,
}

public abstract class ComCfg : lib.Config
{
	public abstract Com create();
}

public record Com( ComId id )
{

}

public class EntityCfg : lib.Config
{
	public readonly ImmutableArray<res.Ref<ComCfg>> Coms;
}



public record Entity<ID>(ID _id)
{
	public ImmutableDictionary<ComId, Com> Com { get; set; } = ImmutableDictionary<ComId, Com>.Empty;
}














}