const fruits = ['Apple','Orange','Banana','Watermelon'];

function ListRendering () {
    return (
        <div>
            <h2>List Rendering Example</h2>
            <ul>
                {fruits.map(item => <li key={item}>{item}</li>)}
            </ul>
        </div>
    )

}

export default ListRendering;