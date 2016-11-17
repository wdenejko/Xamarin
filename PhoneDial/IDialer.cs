using System;

namespace Services {
	public interface IDialer
	{
		bool Dial(string number);
	}
}