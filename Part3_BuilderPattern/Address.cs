public class Address
{
	public string Street { get; }
	public string City { get; }
	public string State { get; }
	public string ZipCode { get; }
	public string Country { get; }

	public Address(string street , string city ,string state , string zipCode ,string country) 
	{ 
		Street = street;
		City = city;
		State = state;
		ZipCode = zipCode;
		Country = country;
	}

}
public class AddressBuilder
{
	private string _street;
	private string _state;
	private string _city;
	private string _country;
	private string _zipCode;

	public AddressBuilder Street(string street)
	{
		_street = street;
		return this;
	}
	public AddressBuilder City(string city)
	{
		_city = city;
		return this;
	}
	public AddressBuilder State(string state)
	{
		_state = state;
		return this;
	}
	public AddressBuilder Country(string country)
	{
		_country = country;
		return this;
	}
	public AddressBuilder ZipCode(string code)
	{
		_zipCode = code;
		return this;
	}

	public Address Build()
	{
		return new Address(_street, _city, _state, _zipCode, _country);
	}
}