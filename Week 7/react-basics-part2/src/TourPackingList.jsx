import Item from "./Item";

const items = [
    {
        name: 'Jacket',
        isPacked: true,
    },
    {
        name: 'TShirt',
        isPacked: false,
    },
    {
        name: 'Helment',
        isPacked: false,
    },
    {
        name: 'Sunglasses',
        isPacked: false,
    }
]

function TourPackingList () {

    return (
        <div >
            <h2>My Tour Packing List</h2>
            <ul>
                {items.map(item => <Item key={item.name} isPacked={item.isPacked} name={item.name} />)}
            </ul>
        </div>
    )
}

export default TourPackingList;