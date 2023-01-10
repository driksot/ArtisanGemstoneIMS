using ArtisanGemstoneIMS.Domain.Common.Models;

namespace ArtisanGemstoneIMS.Domain.CustomerAggregate.ValueObjects;

public sealed class CustomerId : ValueObject
{
	public Guid Value { get; }

	private CustomerId(Guid value)
	{
		Value = value;
	}

	public static CustomerId CreateUnique()
	{
		return new CustomerId(Guid.NewGuid());
	}

	public static CustomerId Create(Guid value)
	{
		return new CustomerId(value);
	}

	public override IEnumerable<object> GetEqualityComponents()
	{
		yield return Value;
	}
}