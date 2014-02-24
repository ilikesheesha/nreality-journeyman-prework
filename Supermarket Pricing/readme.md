#Problem 2: Supermarket Pricing
The task is to model Supermarket Pricing. This is one of the original Pragmatic Programmers Code Kata's, and is intended to be more a thought exercise than a coding exercise.

Some things in supermarkets have simple prices, i.e. a can of beans costs $0.65. 

Other things have more complex prices, for example:

* Three for a dollar (so what's the price if I buy 4, or 5?)
* $1.99/pound (so what does 4 ounces cost?)
* Buy two; get one free (so does the third item have a price?)

The exercise is to experiment with various models for representing money and prices that are flexible enough to deal with these (and other) pricing schemes, and at the same time are generally usable (at the checkout, for stock management, order entry, and so on). 

Time should be spent considering issues such as:

* Does fractional money exist?
* When (if ever) does rounding take place?
* How do you keep an audit trail of pricing decisions (and do you need to)?
* Are costs and prices the same class of thing?
* If a shelf of 100 cans is priced using "buy two, get one free", how do you value the stock?

#Output
This Kata has been approached in a phased exploratory fashion. Starting with a very simple pricing model, each phase phase builds on and/or modifies the previous phase as the complexities of SUpermarket Pricing are explored.

##Phase 1
The very simplest Supermarket Pricing model does not accommodate any Product Pricing strategy. The complexities of Product Pricing and Discounting are handled manually by the Teller during the Checkout process. 

The model at it's core comprises a Product and a Checkout:

* The Product has a Name (Description / Code), a Price, and a Cost.The Price of a Product is set during a back office data capturing exercise, and the Cost of the Product is by default the Price of the Product. For Products where the Price is variable by weight the Price is not set, and the Cost is also not set.
* The Checkout has a list of Product Items and the Cost for each Item is either the default Price for the Product or it is manually overridden during the Checkout process to accommodate a Pricing Strategy. Products where the Price is variable by weight have their Costs manually captured during the Checkout process. The Checkout model assumes that the Cost for each Product Item in the Product Items list is the amount that the Customer is to be Charged. Quantity is represented by the number of Product Items in the Checkout List. 

Product prices are not rounded, and rounding is done a the last possible moment during the Checkout process.

    Product
        Name         String 
        Price        Decimal
        Cost         Decimal

    Checkout
        ProductItems =   List<Products>

        PrintProductItems()
        	FOREACH DISTINCT(ProductItems.Name)
            	PRINT    ItemList.GroupBy(Name):      Name:      Sum_And_Round(ItemList.Filter(Name).Cost)

        PrintTotal()
            PRINT    Sum_And_Round(ItemList.Price)

##Phase 2
At this point we want to take the Pricing Strategies that the Teller would need to handle manually and introduce them to the model. we will first separate the responsibility of the Product definition from the definition of Checkout Product Items.

The model now comprises a Product, PricingStrategy, CheckoutProductItem, and Checkout:

* The Product now has a Name (Description / Code) and a PricingStrategy.
* The PricingStrategy contains the rules that can be applied during the checkout process to calculate the Cost of the Product to be charged to the Customer......


