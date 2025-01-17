import {useEffect, useState} from "react";

import Navbar from "./components/Navbar"
p
function AppBad() {
  const [inventory, setInventory] = useState([])
  const [editingItem, setEditingItem] = useState(null)

  const [name, setName] = useState("")
  const [quantity, setQuantity] = useState("")
  const [category, setCategory] = useState("")
  const [price, setPrice] = useState("")
  const [description, setDescription] = useState("")

  async function fetchInvetory() {
    try {
      const response = await fetch("http://localhost:5000/api/Products");
      const data = await response.json();
      setInventory(data)
    } catch (error){
      console.error("Error fetching inventory")
    }
  }

  useEffect(() => {
    fetchInvetory()
  },[])

  useEffect(() => {
    if(editingItem){
        setName(editingItem.name)
        setQuantity(editingItem.quantity)
        setCategory(editingItem.category)
        setPrice(editingItem.price)
        setDescription(editingItem.description)
    } 
},[editingItem])

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
          
          if(!editingItem){
              const response  = await fetch("http://localhost:5000/api/Products", {
                  method: "POST",
                  headers: {
                      "Content-Type": "application/json"
                  },
                  body: JSON.stringify(newProduct)
              })

              if(!response.ok) throw new Error("Error adding product")
              const savedItem = await response.json()
              const newInventory = [...inventory,savedItem]
              setInventory(newInventory)
          }else{
              const response  = await fetch(`http://localhost:5000/api/Products/${editingItem.id}`, {
                  method: "PUT",
                  headers: {
                      "Content-Type": "application/json"
                  },
                  body: JSON.stringify(newProduct)
              })
              if(!response.ok) throw new Error("Error updating product")
              const updatedProduct = {...newProduct, id: editingItem.id}
              const index = inventory.findIndex(item => item.id === editingItem.id)
              const newInventory = [...inventory]
              newInventory[index] = updatedProduct
              setInventory(newInventory)
          }
          clearForm()
          setEditingItem(null)
      }catch(error){
          const message = editingItem ? "Error updating product" : "Error adding product"
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
      setEditingItem(null)
      clearForm()
  }

  async function handleDeleteProduct(item) {
    if(!confirm("Are you sure you want to delete this product?")) return
    try{
        const response = await fetch(`http://localhost:5000/api/Products/${item.id}`,{
            method: "DELETE"
        });
        if(!response.ok) throw new Error("Error deleting product")
        const newInventory = inventory.filter(i => i.id !== item.id);
        setInventory(newInventory);
    }catch(error){
        console.error("Error deleting product")
    }
}

  return (
    <div>
      <Navbar />
      <div className="container">
        <div className="form-container">
          <h2>{editingItem ? 'Update Product' : 'Add Product'}</h2>
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
                {editingItem &&  <button type="button" className="cancel-edit" onClick={handleCancelEdit}>Cancel Edit</button>}
            <button type="submit">{editingItem ? 'Update Product' : 'Add Product'}</button></div>
          </form>
        </div>
        <div className="table-container">
            <table>
                <thead>
                    <tr>
                        <th>Product Name</th>
                        <th>Category</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Description</th>
                        <th>Actions</th>
                    </tr>
                </thead>
                <tbody>
                    {inventory.map(item => {
                        return (
                            <tr key={item.id}>
                                <td>{item.name}</td>
                                <td>{item.category}</td>
                                <td>{item.price}</td>
                                <td>{item.quantity}</td>
                                <td>{item.description}</td>
                                <td className="action-buttons">
                                    <button className="edit" onClick={() => setEditingItem(item)}>Edit</button>
                                    <button className="delete" onClick={ () => handleDeleteProduct(item)}>Delete</button>
                                </td>
                            </tr>
                        )
                    })}
                    
                </tbody>
            </table>
        </div>
      </div>
    </div>
  )
}

export default AppBad
