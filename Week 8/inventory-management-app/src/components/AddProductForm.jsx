import { useEffect, useState } from "react";

function AddProductForm(props){
    const [name, setName] = useState("")
    const [quantity, setQuantity] = useState("")
    const [category, setCategory] = useState("")
    const [price, setPrice] = useState("")
    const [description, setDescription] = useState("")

    useEffect(() => {
        if(props.editingItem){
            setName(props.editingItem.name)
            setQuantity(props.editingItem.quantity)
            setCategory(props.editingItem.category)
            setPrice(props.editingItem.price)
            setDescription(props.editingItem.description)
        } 
    },[props.editingItem])

    async function handleSubmit(event){
        event.preventDefault()
        if(!name || !quantity || !category || !price || !description){
            alert("Please fill all the fields")
            return
        }
        try{
            const newProduct = {
                name,
                quantity,
                category, // sorthand for category: category
                price: price,
                description: description
            }
            
            if(!props.editingItem){
                const response  = await fetch("http://localhost:5000/api/Products", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(newProduct)
                })
    
                if(!response.ok) throw new Error("Error adding product")
                const savedItem = await response.json()
                const newInventory = [...props.inventory,savedItem]
                props.setInventory(newInventory)
            }else{
                const response  = await fetch(`http://localhost:5000/api/Products/${props.editingItem.id}`, {
                    method: "PUT",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(newProduct)
                })
                if(!response.ok) throw new Error("Error updating product")
                const updatedProduct = {...newProduct, id: props.editingItem.id}
                const index = props.inventory.findIndex(item => item.id === props.editingItem.id)
                const newInventory = [...props.inventory]
                newInventory[index] = updatedProduct
                props.setInventory(newInventory)
            }
            clearForm()
            props.setEditingItem(null)
        }catch(error){
            const message = props.editingItem ? "Error updating product" : "Error adding product"
            console.error(message);
        }
    }
    function clearForm(){
        setName("")
        setQuantity("")
        setCategory("")
        setPrice("")
        setDescription("")
    }
    function handleQuantityChange(event){
        setQuantity(event.target.value)
    }

    function handleCategoryChange(event){
        setCategory(event.target.value)
    }

    function handlePriceChange(event){
        setPrice(event.target.value)
    }

    function handleDescriptionChange(event){
        setDescription(event.target.value)
    }
    
    function handleCancelEdit(){
        props.setEditingItem(null)
        clearForm()
    }
        
    return (
        <div className="form-container">
          <h2>{props.editingItem ? 'Update Product' : 'Add Product'}</h2>
          <form onSubmit={handleSubmit}>
            <input type="text" placeholder="Product Name" value={name} onChange={(e) => setName(e.target.value)}/>
            <select value={category} onChange={handleCategoryChange}>
                <option value="">Select Category</option>
                <option value="Electronics">Electronics</option>
                <option value="Clothes">Clothes</option>
                <option value="Grocery">Grocery</option>
                <option value="Books">Books</option>
            </select>
            <input type="number" placeholder="Price" value={price} onChange={handlePriceChange} />
            <input type="number" placeholder="Quantity" value={quantity} onChange={handleQuantityChange} />
            <textarea rows={3} placeholder="Description" value={description} onChange={handleDescriptionChange}></textarea>
            <div>
                {props.editingItem &&  <button type="button" className="cancel-edit" onClick={handleCancelEdit}>Cancel Edit</button>}
            <button type="submit">{props.editingItem ? 'Update Product' : 'Add Product'}</button></div>
          </form>
        </div>
    )
}

export default AddProductForm;