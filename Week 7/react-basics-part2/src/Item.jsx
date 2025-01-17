function Item (props) {
    if(props.isPacked){
        return <li>{props.name} ✅</li>
    }
    return <li>{props.name}</li>
}

export default Item;