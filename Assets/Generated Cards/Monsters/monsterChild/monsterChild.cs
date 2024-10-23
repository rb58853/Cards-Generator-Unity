using System;
namespace Cards
{
	class monsterChild : Monster
	{
		public new Int32 healt { get; private set; }
		private new Int32 atkToIncrese;
		private  static new Int32 staticInt;
		private new String privateString;
		private  static new String varStaticProp;
		public monsterChild(Int32 atk = 0, Int32 atkArea = 0, Int32 defense = 0, Int32 healt = 0, String name = "name", String description = "description", Int32 atkToIncrese = 0, String nullSet = "nullSet", String privateString = "privateString", String protectedString = "protectedString")
		{
			this.atk = atk;
			this.atkArea = atkArea;
			this.defense = defense;
			this.healt = healt;
			this.name = name;
			this.description = description;
			this.atkToIncrese = atkToIncrese;
			this.nullSet = nullSet;
			this.privateString = privateString;
			this.protectedString = protectedString;
		}
	}
}
