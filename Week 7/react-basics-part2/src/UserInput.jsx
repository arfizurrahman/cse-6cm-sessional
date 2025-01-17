import { useState } from 'react';
function UserInput(){
   const [text, setText] = useState('');

    const handleChange = (event) => {
     setText(event.target.value);
    }
    return (
        <div>
            <h2>User Input Example</h2>
            <input type='text' placeholder='Type Something' onChange={handleChange}/>
            <p>Your typed: {text}</p>
        </div>
    )
}

export default UserInput;