function Event () {
    const handleClick = () => {
        alert("Button Clicked");
    };

    return (
        <div>
            <h2>Event Handling Example</h2>
            <button onClick={handleClick}>Click Me</button>
      </div>
    )
}

export default Event;