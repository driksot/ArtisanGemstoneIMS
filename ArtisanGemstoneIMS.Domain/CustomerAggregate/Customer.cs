using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.Common.ValueObjects;
using ArtisanGemstoneIMS.Domain.CustomerAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.CustomerAggregate;

public sealed class Customer : AggregateRoot<CustomerId>
{
	public string FirstName { get; }
	public string LastName { get; }
	public Address PrimaryAddress { get; }
	public bool IsArchived { get; }

	public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

	private Customer(
		CustomerId customerId,
		string firstName,
		string lastName,
		Address primaryAddress,
		bool isArchived)
		: base(customerId)
	{
		FirstName = firstName;
		LastName = lastName;
		PrimaryAddress = primaryAddress;
		IsArchived = isArchived;
	}

	public static Customer Create(
		string firstName,
		string lastName,
		Address primaryAddress)
	{
		return new Customer(
			CustomerId.CreateUnique(),
			firstName,
			lastName,
			primaryAddress,
			false);
	}
}