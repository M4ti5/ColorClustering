
using ColorClustering;
using System;
using System.Collections.Generic;
using Xunit;
using static ColorClustering.PixelTree;

namespace ColorClusteringTests {
    public class UnitTestsPixelTree {

        List<Pixel> nodes = new List<Pixel> {
                new DBSNode(25,10,15),
                new DBSNode(15,10,15),
                new DBSNode(30,10,15),
                new DBSNode(15,5,15),
                new DBSNode(15,5,10),
                new DBSNode(15,5,20),
                new DBSNode(30,15,20),
        };


        [Fact]
        public void PixelTreeSimpleAdd () {
            PixelTree tree = new PixelTree(nodes[0]);
            Console.WriteLine(tree.ToString());
            Assert.True(tree.root.node.red == 25, tree.root.node.red.ToString());
        }

        [Fact]
        public PixelTree PixelTreeMultipleAdd () {
            PixelTree tree = new PixelTree(nodes[0]);
            for(int i =0 ; i< nodes.Count ;i++) {
                tree.AddNode(nodes[i]);
            }
            Assert.True(tree.root.leftChild.leftChild.leftChild.node == nodes[4]);

            return tree;
        }

        [Fact]
        public void PixelTreeSearch () {
            PixelTree tree = PixelTreeMultipleAdd();
            Assert.True(tree.SearchNode(tree.root, nodes[3]).node == nodes[3]); ;
        }

        [Fact]
        public void PixelTreeContains () {
            PixelTree tree = PixelTreeMultipleAdd();
            Assert.True(tree.Contains(nodes[3])); ;
        }

        [Fact]
        public void PixelTreeFindMax () {
            PixelTree tree = PixelTreeMultipleAdd();
            Assert.True(tree.FindMax(tree.root).node == nodes[6]);
        }

        [Fact]
        public void PixelTreeRemoveWithoutChild () {
            PixelTree tree = PixelTreeMultipleAdd();

            tree.RemoveNode(nodes[6]);
            Assert.True(tree.root.rightChild.rightChild == null );
        }

        [Fact]
        public void PixelTreeRemoveWithOneChildLeft () {
            PixelTree tree = PixelTreeMultipleAdd();
            tree.RemoveNode(nodes[1]);
            
            Assert.True(tree.root.leftChild.node == nodes[3]);
            Assert.True(tree.root.leftChild.parent.node == nodes[0]);
        }

        [Fact]
        public void PixelTreeRemoveWithOneChildRight () {
            PixelTree tree = PixelTreeMultipleAdd();

            tree.RemoveNode(nodes[2]);
            Assert.True(tree.root.rightChild.node == nodes[6]);
            Assert.True(tree.root.rightChild.parent.node == nodes[0]);
        }

        [Fact]
        public void PixelTreeRemoveWith2Childs () {
            PixelTree tree = PixelTreeMultipleAdd();
            tree.RemoveNode(nodes[3]);
            //Child binds
            Assert.True(tree.root.leftChild.leftChild.node == nodes[4] && tree.root.leftChild.leftChild.rightChild.node == nodes[5]);
            //Parent binds
            Assert.True(tree.root.leftChild.leftChild.parent.node == nodes[1] && tree.root.leftChild.leftChild.rightChild.parent.node == nodes[4]);

        }

        [Fact]
        public void PixelTreeRemoveMultiple () {
            PixelTree tree = PixelTreeMultipleAdd();

            tree.RemoveNode(nodes[3]);
            tree.RemoveNode(nodes[1]);
            tree.RemoveNode(nodes[2]);

            //Childs binds
            //Parents binds

            Assert.True(tree.root.leftChild.node == nodes[4]);
            Assert.True(tree.root.leftChild.parent.node == nodes[0]);

            Assert.True(tree.root.leftChild.rightChild.node == nodes[5]);
            Assert.True(tree.root.leftChild.rightChild.parent.node == nodes[4]);


            Assert.True(tree.root.rightChild.node == nodes[6]);
            Assert.True(tree.root.rightChild.parent.node == nodes[0]);

            Assert.True(tree.SearchNode(tree.root, nodes[4]) != null);
        }

        [Fact]
        public void PixelTreeToList () {
            PixelTree tree = PixelTreeMultipleAdd();
            List<Pixel> temp = tree.ToList();
            foreach(Pixel elem in nodes) {
                if (!temp.Contains(elem)) {
                    Assert.True(false);
                } else {
                    Assert.True(true);
                }
            }
        }
    }
}
