function ProductsTable (props) {

    async function handleDeleteProduct(item) {
        if(!confirm("Are you sure you want to delete this product?")) return
        try{
            const response = await fetch(`http://localhost:5000/api/Products/${item.id}`,{
                method: "DELETE"
            });
            if(!response.ok) throw new Error("Error deleting product")
            const newInventory = props.inventory.filter(i => i.id !== item.id);
            props.setInventory(newInventory);
        }catch(error){
            console.error("Error deleting product")
        }
    }
    return (
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
                    {props.inventory.map(item => {
                        return (
                            <tr key={item.id}>
                                <td>{item.name}</td>
                                <td>{item.category}</td>
                                <td>{item.price}</td>
                                <td>{item.quantity}</td>
                                <td>{item.description}</td>
                                <td className="action-buttons">
                                    <button className="edit" onClick={() => props.setEditingItem(item)}>Edit</button>
                                    <button className="delete" onClick={ () => handleDeleteProduct(item)}>Delete</button>
                                </td>
                            </tr>
                        )
                    })}
                    
                </tbody>
            </table>
        </div>
    )
}

export default ProductsTable;