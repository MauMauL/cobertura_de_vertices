$(document).ready(function(){

    var cy = cytoscape({
        container: $('#cy'),
        elements: [ // list of graph elements to start with
            { // node a
              data: { id: 'a' }
            },
            { // node b
              data: { id: 'b' }
            },
            { // edge ab
              data: { id: 'ab', source: 'a', target: 'b' }
            }
          ],
        
          style: [ // the stylesheet for the graph
            {
              selector: 'node',
              style: {
                'background-color': '#666',
                'label': 'data(id)'
              }
            },
        
            {
              selector: 'edge',
              style: {
                'width': 3,
                'line-color': '#ccc',
                'target-arrow-color': '#ccc',
                'target-arrow-shape': 'triangle'
              }
            }
          ],
        
          layout: {
            name: 'grid',
            rows: 1
          }
      });

      var eles = cy.add([
        { group: "nodes", data: { id: "n0" }, position: { x: 100, y: 100 } },
        { group: "nodes", data: { id: "n1" }, position: { x: 200, y: 200 } },
        { group: "edges", data: { id: "e0", source: "n0", target: "n1" } }
      ]);

});