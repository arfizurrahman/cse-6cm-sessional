import {useState} from 'react';

function Form(){
    const [name, setName] = useState("Laptop");
    const [quantity, setQuantity] = useState("10");

    function handleSubmit(event){
        event.preventDefault();
        console.log('Form submitted');
        console.log('Name:', name);
        console.log('Quantity:', quantity);	
    }

    function handleNameChange(event){
        setName(event.target.value);
    }

    function handleQuantityChange(event){
        setQuantity(event.target.value);
    }

    return (
        <form onSubmit={handleSubmit}>
            <input type="text" placeholder="Name" value={name} onChange={handleNameChange}/>
            <input type="text" placeholder="Quantity" value={quantity} onChange={handleQuantityChange} />
            <button type="submit">Submit</button>
        </form>
    )
}

export default Form;