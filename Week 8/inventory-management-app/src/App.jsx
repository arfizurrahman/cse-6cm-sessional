import {useEffect, useState} from "react";

import AddProductForm from "./components/AddProductForm"
import Navbar from "./components/Navbar"
import ProductsTable from "./components/ProductsTable"

function App() {
  const [inventory, setInventory] = useState([])
  const [editingItem, setEditingItem] = useState(null)

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

  return (
    <div>
      <Navbar />
      <div className="container">
        <AddProductForm editingItem={editingItem} setEditingItem={setEditingItem} inventory={inventory} setInventory={setInventory}/>
        <ProductsTable inventory={inventory} setEditingItem={setEditingItem} setInventory={setInventory}/>
      </div>
    </div>
  )
}

export default App
