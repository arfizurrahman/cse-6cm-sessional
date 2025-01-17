import { useState } from "react";

function Counter(){
    const [count, setCount] = useState(0);

    const handleIncrement =() => {
        setCount(count + 1);
    }

    const handleDecrement =() => {
        setCount(count - 1);
    }

    return (
        <div>
            <h2>Counter App</h2>
            <p>Count: {count}</p>
            <button style={{marginRight: '8px'}} onClick={handleIncrement}>Increment</button>
            <button onClick={handleDecrement}>Decrement</button>
        </div>
    )
}

export default Counter;
