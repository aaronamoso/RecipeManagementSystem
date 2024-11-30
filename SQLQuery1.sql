PRINT N'Creating Recipes...';
GO
CREATE SCHEMA [Recipes]
		AUTHORIZATION [dbo];
GO

PRINT N'Creating Recipes.Recipe...';
GO
CREATE TABLE [Recipes].[Recipe] (
		[RecipeID] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
		[RecipeName] NVARCHAR(40) NOT NULL,
		[RecipeAuthor] NVARCHAR(40) NOT NULL,
		[Ingredients] NVARCHAR(MAX) NOT NULL,
		[Instructions] NVARCHAR(MAX) NOT NULL,
		[CookTime] INT NOT NULL, -- Storing as minutes
		[PrepTime] INT NOT NULL, -- Storing as minutes
		[ServingSize] NVARCHAR(40) NOT NULL,
		[Calories] INT NOT NULL, -- Numeric for easier calculations
		[Difficulty] NVARCHAR(40) NOT NULL,
		[DietaryRestrictions] NVARCHAR(60) NULL,
		[Season] NVARCHAR(20) NOT NULL,
		[Type] NVARCHAR(30) NOT NULL
);
GO

PRINT N'Creating Recipes.Image...';
GO
CREATE TABLE [Recipes].[Image] (
		[ImageID] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, -- Add a unique identifier for images
		[RecipeID] INT NOT NULL,
		[RecipePhoto] VARBINARY(MAX) NOT NULL,
		FOREIGN KEY ([RecipeID]) REFERENCES [Recipes].[Recipe]([RecipeID]) ON DELETE CASCADE
);
GO

INSERT INTO [Recipes].[Recipe] (
		[RecipeName],
		[RecipeAuthor],
		[Ingredients],
		[Instructions],
		[CookTime],
		[PrepTime],
		[ServingSize],
		[Calories],
		[Difficulty],
		[DietaryRestrictions],
		[Season],
		[Type]
) VALUES 
(
		'Spaghetti Bolognese',
		'Duane L',
		'500g Spaghetti noodles, 250g ground beef, 1 medium onion chopped, 3 cloves of garlic - minced, 250 ml tomato sauce, 5 ml oregano, 2.5 ml basil, 30 ml sugar',
		'1. Cook spaghetti. 2. Brown beef with onion and garlic. 3. Add sauce, herbs, and sugar.',
		'30', 
		'10',
		'4 servings',
		'400',
		'Medium',
		'Dairy-free',
		'Winter',
		'Dinner'
),
(
		'Chicken Curry',
		'Janine N.',
		'1 kg Chicken, 30 ml curry powder, 250 ml coconut milk, 1 medium onion, 3 carrots, 2 cloves of garlic, 2 teaspoons of grated ginger root',
		'1. Brown chicken with onion, garlic, ginger. 2. Add curry powder. 3. Stir in coconut milk and simmer but do not boil. 4. Serve with cooked rice.',
		'40',
		'15',
		'6 servings',
		'500',
		'Medium',
		'Dairy-free',
		'Any',
		'Main Course'
),
(
		'Taco Salad',
		'Aaron A.',
		'30 ml Ranch-style dressing, 15 ml mild salsa, 15 ml chopped chives
		 250 ml lettuce, 60 ml diced Roma tomatoes,
		 60 ml chopped green onions, 125 ml diced cucumbers,
		 125 ml shredded jalapeno Monterey jack cheese, 
		 60 ml shredded carrots, 125 ml avocado chunks,
		 250 ml Doritos tortilla chips, any flavour,
		 60 ml chopped cilantro, optional,
		 Sliced lemon or lime, optional',
		'1. Blend ranch dressing, salsa, and chives for dressing
		 2. Tear or cut lettuce into bite size chunks, place in medium size mixing bowl
		 3. Add remaining ingredients except for chips, cilantro and lime or lemon into bowl with lettuce, toss gently 
		 4. Garnish with cilantro and lemon or lime if desired and drizzle with dressing
		 5. Serve with tortilla chips on the side',
		'0', 
		'15',
		'2 servings',
		'400',
		'Easy',
		'None',
		'Summer',
		'Lunch'
),
(
		'Charcuterie Board',
		'Duane L.',
		'60 ml Gluten-free blue cheese, 60 ml gluten-free Brie cheese, 2 slices gluten-free baguette, 4 gluten-free crackers,
		6 cashew nuts,3 almonds,8 raisins or dried cranberries, 2 sliced black olives, 2 sliced green olives, 4 slices of green apple - dipped in 15 ml of lemon juice to coat,
		6 red grapes,2 slices of Gluten-free Felino salami',
		'1.	Prepare all ingredients, slicing as necessary
		2.	Arrange on a decorative plate or charcutterie board when ready to serve
		3.	to make ahead, arrange on serving dish and cover tightly with plastic wrap and store in refrigerator up to 4 hours until ready to serve',
		'0',
		'15',
		'1 serving',
		'500',
		'Easy',
		'Gluten-free',
		'Fall',
		'Snack'
),
(
		'Banana-Choco Apples',
		'Aaron A.',
		'2 medium bananas, 60 ml peanut butter, 30 ml vegan chocolate chips, 2 apples',
		'1. Mash the bananas until they are smooth 2. Put the peanut butter and chocolate chips and bananas into the microwave and cover.
		3. Microwave on high for 60 seconds then mix well 4. Slice apples and spread with the banana spread',
		'1',
		'10',
		'2 servings',
		'230',
		'Easy',
		'Vegan',
		'Summer',
		'Breakfast'
),
(   
		'Savory Mashed Potatoes',
		'Janine N.',
		'1 kg of potatoes, 8 cups of water, 250g vegetarian cream cheese, 10 ml summer savory, 3 cloves minced garlic, 2 ml salt, 75 ml minced onion',
		'1. Peel potatoes and place in the water in a large pot 
		2. Bring to a boil cooking until tender 3. Drain potatoes
		4. Add remaining ingredients and mash until smooth 5. Serve warm',
		'25',
		'20',
	 '6 servings',
		'365',
		'Medium',
		'Vegetarian',
		'Winter',
		'Special'
),
(
		'Pasta-To-Go Sandwich ',
		'Duane L.',
		'30 ml butter, 4 slices of cheese and herb bread, 125 ml grated gouda cheese, 100 ml canned pasta in tomato sauce',
		'1. Spread all the bread on one side with butter 2. On a baking sheet place 2 slices of bread with the buttered side down 3. Sprinkle bread with cheese 
		4. Arrange pasta on top of cheese 5. Place the remaining bread buttered side up on top of the pasta 6. Brown in oven until cheese is melted',
		'15', 
		'5',
		'2 servings',
		'420',
		'Medium',
		'None',
		'Spring',
		'Lunch'
),
(
		'Deluxe Pita Pizzas',
		'Aaron A.',
		'4 large whole wheat pita breads, 250 ml pizza sauce, 75 ml sliced olives, 60 ml diced red onions, 2 Roma tomatoes sliced thin, 1 cup chopped asparagus,
		500 ml grated vegetarian mozzerella cheese, 30 ml dried oregano',
		'1. Place 2 pitas on each cookies sheet 2. Spread sauce on pitas 3. Sprinkle on remaining toppings 
		4. Bake at 375F for 20 minutes 5. Remove from oven and cool slightly 6. Cut each pita into 4 pieces and serve',
		'20',
		'10',
		'12 servings',
		'259',
		'Easy',
		'Vegetarian',
		'Spring',
		'Lunch'
),
(
		'Cheesy Crab Panini',
		'Janine N.',
		'250 ml cooked crab meat, 250 ml grated cheddar cheese, 60 ml chopped celery, 60 ml chopped sweet red pepper, 30 ml sweet green pickles diced, 60 ml chopped green onions, 1 hard boiled egg chopped, 125 ml mayonnaise, 5 ml lemon juice, 2.5 ml minced horseradish
		One 350g loaf of Foccacia bread',
		'1. Gently combine all ingredients except bread slices 2. Quarter the foccacia bread and cut each quarter in half 3. Spread 4 of the halved pieces of bread with the filling and top with remaing 4 bread pieces 4. Brush with oil or spread with butter 
		and place on a grill or panini press for 5 minutes until heated through',
		'5', 
		'10',
		'4 servings',
		'641',
		'Advanced',
		'None',
		'Winter',
		'Lunch'
),

(
		'Dessert Bars',
		'Janine N.',
		'375 ml crunchy peanut butter, 1/2 cup chopped peanuts, 1 egg, 175ml sugar, 
     1 cup chocolate chips for glaze',
		'Combine all ingredients except chocolate chips and blend well 
    2. Press into 20 x 20 cm pan that has been lined with tin foil 
    3. Bake at 325F for 30 minutes 
    4. Remove from oven and immediately sprinkle the chocolate chips on top 
    5. Cover with tin foil and let set until chocolate chips are melted 
		6. Spread chocolate chips evenly across top and let cool completely in refrigerator 
		7. Cut into 16 pieces and serve',
	 '30', 
		'5',
		'16 servings',
		'282',
		'Easy',
		'None',
		'Spring',
		'Dessert'
),
(
		'Rhubarb Pineapple Jam',
		'Duane L.',
		'2 cups rhubarb cut in chunks, 625 ml sugar,       325 ml can crushed pineapple, 1 pkg strawberry gelatin powder',
		'1. Mix sugar with fruit 2. Place in saucepan and bring to boil      3. Reduce heat and boil for 20 minutes      4. Remove from heat and stir in jelly powder until crystals are dissolved     
     5. Cool and bottle ',
		'20', 
		'15',
		'6 servings',
		'57',
		'Advanced',
		'Dairy-free',
		'Fall',
		'Special'
),
  (
		'Butter Crunch Sundae',
		'Aaron A.',
		'75 ml Honey Bunches of Oats cereal, 60 ml sweetened flaked coconut, 1 scoop of vanilla ice cream,       75 ml caramel syrup',
		'1. Crush cereal into small bits 2. Place ice cream in serving bowl 3. Top with remaining ingredients and serve immediately',
		'0', 
		'5',
		'1 serving',
		'480',
		'Easy',
		'None',
		'Summer',
		'Dessert'
),
  
  (
		'Salmon Teriyaki',
		'Janine N.',
		' 750g salmon fillets skins off, 60 ml olive oil, 250g cremini mushrooms sliced,      150 g bean sprouts, 90ml Tamari sauce, 100 ml sake, 75 ml sweet mirin, 75 ml honey',
		'1. Combine Tamari and sake and mirin and honey add salmon and let rest for 15 minutes in refrigerator      2. Brown mushrooms in oil in saucepan 3. Add bean sprouts and heat through       4. Drain salmon and reserve marinade 5. Cook salmon 4 minutes on each side until begins to brown      6. Pour marinade over salmon and continue to cook for 5 more minutes       
     7. Arrange mushrooms and sprouts on serving plates and add a piece of salmon to each 8. Serve warm ',
		'20', 
		'35',
		'4 servings',
		'347',
		'Advanced',
		'None',
		'Fall',
		'Dinner'
),
(
  'Coconut Rice',
		'Duane L',
		'400 ml parboiled instant rice, 125 ml flaked coconut, 30 ml butter, 15 ml sugar',
		'1. Cook rice according to package directions 2. Add coconut and butter and sugar to rice and       mix gently 3. Serve warm ',
		'5', 
		'10',
		'4 servings',
		'373',
		'Medium',
		'None',
		'Spring',
		'Special'
),
(
		'Rustic Gemelli Pasta',
		'Aaron A.',
		' 250 g gemelli pasta, 15 ml canola oil, 60 ml sweet red pepper, 60 ml diced onion, 125 ml chopped broccoli,      30 ml honey, 15 ml brown sugar, 
     4 italian sausages - precooked, 
     2.5 ml dried sage, 2.5 ml dried basil',
		'1.Cook pasta in boiling water until tender 2. Drain and set aside 3. In saucepan heat oil and add vegetables cook to brown lightly       
  4. Mix in honey and sugar and seasonings
  5. Toss in sausages and serve warm',
		'25', 
		'20',
		'4 servings',
		'395',
		'Advanced',
		'None',
		'Winter',
		'Dinner'
);


SELECT * FROM [Recipes].[Recipe];
