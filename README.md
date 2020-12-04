# CD-Inventory-API
Small API for an online store's CD inventory

<h3>Example (using Postman)</h3>


            
	Step 1: POST to CdInventory/AddInventory
	    Body:
                {
                "Id": "1",
                "Artist": "Michael Jackson",
                "Album": "Thriller",
                "ReleaseYear": 1985,
                "CopiesAvailabe": 24
                }
                
        Step 2: POST to CdInventory/AddInventory
            Body:
                {
                "Id": "2",
                "Artist": "Disturbed",
                "Album": "Indestructible",
                "ReleaseYear": 2008,
                "CopiesAvailabe": 11
                }
                
        Step 3: GET from CdInventory/DisplayInventory
            It should display both items
            
        Step 4: POST to CdInventory/UpdateInventory/2
            Body:
                {
                "Id": "2",
                "Artist": "Disturbed",
                "Album": "The Sickness",
                "ReleaseYear": 2000,
                "CopiesAvailabe": 7
                }
                
        Step 5: GET from CdInventory/DisplayItem/2
            It should display the updated item 2
            
        Step 6: DELETE at CdInventory/DeleteItem/1
               This should remove item 1
               
        Step 7: GET from CdInventory/DisplayInventory
            It should display item 2 only
            
        Finished :)
								
