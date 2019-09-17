Feature: User can see Promotion details in cart.
    In order to be informed what I am shopping for
    As a new user
    I want to see relevant Promotion details in Cart depending on my selection.

#1
    Scenario: BOX za 1 EUR - No Subscription
        When I select "BOX za 1 EUR" Promotion
        Then in Cart I see "contract lenght".

#2
    Scenario: BOX za 1 EUR - Subscription 3 months
        When I select Promotion "BOX za 1 EUR"
        And I select Subscription "3 meseca"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".
    #ovi parametri bi mogli da budu smesteni u klasu PromotionWithDeviceCartDetails
#3
    Scenario: BOX za 1 EUR - Subscription 6 months
        When I select Promotion "BOX za 1 EUR"
        And I select Subscription "6 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

#4
    Scenario: BOX za 1 EUR - Subscription 12 months
        When I select Promotion "BOX za 1 EUR"
        And I select Subscription "12 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

#5
    Scenario: 50% popusta na box - Predefined Subscription
        When I select Promotion "50% popusta na box"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

#6
    Scenario: BOX bez akcijske cene - No Subscription
        When I select Promotion "BOX bez akcijske cene"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

#7
    Scenario: BOX bez akcijske cene - Subscription 3 months
        When I select Promotion "BOX bez akcijske cene"
        And I select Subscription "3 meseca"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

#8
    Scenario: BOX bez akcijske cene - Subscription 6 months
        When I select Promotion "BOX bez akcijske cene"
        And I select Subscription "6 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

#9
    Scenario: BOX bez akcijske cene - Subscription 12 months
        When I select Promotion "BOX bez akcijske cene"
        And I select Subscription "12 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings", "device price", "device price discount", "device activation fee", "device transportation fee".

    Scenario: 3 meseca gratis - No Subscription
        When I select "3 meseca gratis" Promotion
        Then in Cart I see "contract lenght".
#10
    Scenario: 3 meseca gratis - Subscription 3 months
        When I select Promotion "3 meseca gratis"
        And I select Subscription "3 meseca"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"
    #ovi parametri bi mogli da budu smesteni u klasu PromotionWithoutDeviceCartDetails

#11
    Scenario: 3 meseca gratis - Subscription 6 months
        When I select Promotion "3 meseca gratis"
        And I select Subscription "6 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"

#12
    Scenario: 3 meseca gratis - Subscription 12 months
        When I select Promotion "3 meseca gratis"
        And I select Subscription "12 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"

#13
    Scenario: Plati 10 gledaj 12 meseci - Predefined Subscription
        When I select Promotion "Plati 10 gledaj 12 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"

#14
    Scenario: Izaberi period trajanja pretplate - No Subscription
        When I select Promotion "Izaberi period trajanja pretplate"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"

#15
    Scenario: Izaberi period trajanja pretplate - Subscription 3 months
        When I select Promotion "Izaberi period trajanja pretplate"
        And I select Subscription "3 meseca"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"
#16
    Scenario: Izaberi period trajanja pretplate - Subscription 6 months
        When I select Promotion "Izaberi period trajanja pretplate"
        And I select Subscription "6 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"
#17
    Scenario: Izaberi period trajanja pretplate - Subscription 12 months
        When I select Promotion "Izaberi period trajanja pretplate"
        And I select Subscription "12 meseci"
        Then in Cart I see "contract lenght", "subscription lenght", "subscription amount", "total amount", "savings"
