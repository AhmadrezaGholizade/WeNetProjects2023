const driver = window.driver.js.driver;

const driverObj = driver({
    showProgress: true,
    steps: [
      { element: '#rgb', popover: { title: 'Question', description: 'You should guess the Color From this RGB numbers.' } },
      { element: '#reset', popover: { title: 'Change Color', description: 'From here you can change the question.' } },
      { element: '#Level', popover: { title: 'Change the Level', description: 'You can Play the game with 3 or 6 items.' } },
      { element: '.square', popover: { title: 'Items', description: 'Items for choose' } },
    ]
  });
  
  driverObj.drive();