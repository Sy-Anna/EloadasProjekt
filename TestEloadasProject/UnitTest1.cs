using System;
using EloadasProject;

namespace TestEloadasProject
{
	public class TestEloadas
	{
		public void LefoglalElsoSzabadHelyet()
		{
			Eloadas eloadas = new Eloadas(3, 3);

			bool sikeresFoglalas = eloadas.Lefoglal();

			Assert.True(sikeresFoglalas);
		}

		public void SzabadHelyekSzama()
		{
			Eloadas eloadas = new Eloadas(2, 2);
			eloadas.Lefoglal();

			int szabadHelyek = eloadas.SzabadHelyek;

			Assert.Equal(3, szabadHelyek);
		}

		public void EloadasTeli()
		{
			Eloadas eloadas = new Eloadas(1, 1);
			eloadas.Lefoglal();

			bool teli = eloadas.Teli;

			Assert.True(teli);
		}

		public void FoglaltHelyEllenorzes()
		{
			Eloadas eloadas = new Eloadas(2, 2);
			eloadas.Lefoglal();

			bool foglalt = eloadas.Foglalt(1, 1);

			Assert.True(foglalt);
		}

		public void HibasHelyenFoglalas()
		{
			Eloadas eloadas = new Eloadas(2, 2);

			Assert.Throws<ArgumentException>(() => eloadas.Foglalt(0, 0));
		}
	}
}
