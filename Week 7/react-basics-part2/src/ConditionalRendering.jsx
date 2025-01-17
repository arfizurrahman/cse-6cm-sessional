import { useState } from "react";

function ConditionalRendering(props){
    const [isLoggedIn, setIsLoggedIn] = useState(false)

    const handleLogin = () =>{
        setIsLoggedIn(true)
    }

    const handleLogout = () => {
        setIsLoggedIn(false)
    }
    
    return (
        <div>
            {props.showTitle && <h2>Conditional Rendering Example</h2>}
            {isLoggedIn ? <h3>Welcome Back!</h3> : <h3>Please log in!</h3>}
            {isLoggedIn ? <button onClick={handleLogout}>Logout</button> 
            : <button onClick={handleLogin}>Login</button>}
            
        </div>
    )
}

export default ConditionalRendering;