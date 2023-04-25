using System;

public class Operation
{
	private string type;
	private double montant;

	public Operation()
	{
	}
	public Operation(string typeOperation, double montantOperation)
	{
		this.type = typeOperation;
		this.montant = montantOperation;
	}
}
