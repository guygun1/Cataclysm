using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Cataclysm.Content.Items
{
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class fish : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.Cataclysm.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 17;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 30;
			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Goldfish, 1);
			recipe.AddIngredient(ItemID.IronBar, 1);
			recipe.Register();
			recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.Goldfish, 1);
			recipe.AddIngredient(ItemID.LeadBar, 1);
			recipe.Register();
		}
	}
}
